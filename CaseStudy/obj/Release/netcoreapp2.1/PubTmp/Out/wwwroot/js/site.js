﻿$(function () {

    if ($("#register_popup") !== undefined) {
        $('#register_popup').modal('show');
    }

    if ($("#login_popup") !== undefined) {
        $('#login_popup').modal('show');
    }

    // re-pop modal to show newly created add message
    if ($("#selectedId").val() > 0) {
        let data = $("#catbtn" + $("#selectedId").val()).data("details");
        CopyToModal($("#selectedId").val(), data);
        $("#details_popup").modal("show");
    }

    // details click - to load popup on catalogue
    $("a.btn-outline-dark").on("click", (e) => {
        $("#results").text("");
        let id = e.target.dataset.id;
        let data = JSON.parse(e.target.dataset.details); // it's a string need an object
        CopyToModal(id, data);
    });
    $(".nav-tabs a").on("show.bs.tab", function (e) {
        if ($(e.relatedTarget).text() === "Demographic") { // tab 1
            $("#Firstname").valid();
            $("#Lastname").valid();
            $("#Age").valid();
            $("#CreditcardType").valid();
            if ($("#Firstname").valid() === false || $("#Lastname").valid() === false || $("#Age").valid() === false || $("#CreditcardType").valid() === false ) {
                return false; // suppress click
            }
        }
        if ($(e.relatedTarget).text() === "Address") { // tab 2
            $("#Address1").valid();
            $("#City").valid();
            $("#Country").valid();
            $("#Region").valid();
            $("#Mailcode").valid();
            if ($("#Address1").valid() === false || $("#City").valid() === false || $("#Country").valid() === false || $("#Region").valid() === false || $("#Mailcode").valid() === false) {
                return false; // suppress click
            }
        }
        if ($(e.relatedTarget).text() === "Account") { // tab 3
            $("#Email").valid();
            $("#Password").valid();
            $("#RepeatPassword").valid();
            if ($("#Email").valid() === false || $("#Password").valid() === false ||
                $("#RepeatPassword").valid() === false) {
                return false; // suppress click
            }
        }
    }); // show bootstrap tab
});
// populate the modal fields
const CopyToModal = (id, data) => {
    $("#qty").val("0");
    $("#cost").text(data.MSRP);
    $("#description").text(data.Description);
    let image = data.GRA;
    $("#detailsGraphic").attr("src", `/images/${image}`);
    $("#selectedId").val(id);
}