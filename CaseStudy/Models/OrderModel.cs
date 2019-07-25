using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CaseStudy.Models
{
    public class OrderModel
    {
        private AppDbContext _db;
        public OrderModel(AppDbContext ctx)
        {
            _db = ctx;
        }
        public int AddCart(Dictionary<string, object> items, ApplicationUser user)
        {
            int cartId = -1;
            using (_db)
            {
                // we need a transaction as multiple entities involved
                using (var _trans = _db.Database.BeginTransaction())
                {
                    try
                    {
                        Order order = new Order();
                        order.UserId = user.Id;
                        order.OrderDate = System.DateTime.Now;
                        order.OrderAmount = 0;
                        // calculate the totals and then add the order row to the table
                        foreach (var key in items.Keys)
                        {
                            MenuProductViewModel item = JsonConvert.DeserializeObject<MenuProductViewModel>(System.Convert.ToString(items[key]));
                            if (item.Qty > 0)
                            {
                                order.OrderAmount += Convert.ToDecimal(item.MSRP * item.Qty);
                            }
                        }
                        _db.Orders.Add(order);
                        _db.SaveChanges();
                        // then add each item to the OrderlineItem table
                        foreach (var key in items.Keys)
                        {
                            MenuProductViewModel item = JsonConvert.DeserializeObject<MenuProductViewModel>(Convert.ToString(items[key]));
                            if (item.Qty > 0)
                            {
                                OrderLineItem oItem = new OrderLineItem();
                                oItem.OrderId = item.Id;

                                //if enough stock
                                //decrease qtyonhand from product table by qty
                                //QtySold = Qty, QtyOrdered = Qty, QtyBackOrdered = 0 in the line items table
                                oItem.QtyOrdered = item.Qty;
                                oItem.QtySold = item.Qty;
                                oItem.QtyBackOrdered = 0;

                                //if not enough stock
                                //decrease qtyonhand to 0
                                //Increase the QtyOnBackOrdered by the difference between Qty and QtyOnHand in the products table
                                //QtySold = QtyOnHand, QtyOrdered = Qty, QtyBackOrdered = Qty - QtyOnHand

                                oItem.SellingPrice = Convert.ToDecimal(item.MSRP); 
                                oItem.ProductId = item.Id;
                                oItem.Order = order;
                                _db.OrderLineItems.Add(oItem);
                                _db.SaveChanges();
                            }
                        }
                        // test trans by uncommenting out these 3 lines
                        //int x = 1;
                        //int y = 0;
                        //x = x / y;
                        _trans.Commit();
                        cartId = order.Id;
                    }
                    catch (Exception ex)
                    {
                        cartId = -1;
                        Console.WriteLine(ex.Message);
                        _trans.Rollback();
                    }
                }
            }
            return cartId;
        }
    }
}
