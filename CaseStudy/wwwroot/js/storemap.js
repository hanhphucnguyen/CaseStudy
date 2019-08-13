// modal component
Vue.component("storemodal", {
    template: "#modal-template",
    props: {
        details: [],
        lat: '',
        lng: ''
    },
    methods: {
        async showModal() {
            try {
                let response = await fetch(`/GetStores(${lat},${lng})`);
                if (!response.ok) // or check for response.status
                    throw new Error(`Status - ${response.status}, Text - ${response.statusText}`);
                let data = await response.json(); // this returns a promise, so we await it
                this.details = data;
            } catch (error) {
                console.log(error.statusText);
            }
        }
    }
});
const stores = new Vue({
    el: '#stores',
    methods: {
        loadAndShowModal() {
            try {
                // A service for converting between an address to LatLng
                let geocoder = new google.maps.Geocoder();
                geocoder.geocode({ address: this.address }, (results, status) => {
                    if (status === google.maps.GeocoderStatus.OK) {
                        // only if google gives us the OK
                        this.lat = results[0].geometry.location.lat();
                        this.lng = results[0].geometry.location.lng();
                        this.showModal = true;
                        let myLatLng = new google.maps.LatLng(this.lat, this.lng);
                        let map_canvas = document.getElementById("map");
                        //let map_canvas = this.$refs["myid"];
                        let options = {
                            zoom: 10, center: myLatLng, mapTypeId:
                                google.maps.MapTypeId.ROADMAP
                        };
                        let map = new google.maps.Map(map_canvas, options);
                        let center = map.getCenter();
                        map.setCenter(center);
                        google.maps.event.trigger(map, "resize");
                        infowindow = new google.maps.InfoWindow({ content: "" });
                        //add the markers, event handlers, infowindows for each location
                        marker = new google.maps.Marker({
                            position: new google.maps.LatLng(this.lat, this.lng),
                            map: map,
                            animation: google.maps.Animation.DROP,
                            icon: `../images/marker1.png`,
                            title: `Some hover info goes here`,
                            html: `<div>1149 Highbury Ave <br/> London , ON <br/> 0.3 km </div>`                 
                        });         
                        google.maps.event.addListener(marker, "click", () => {
                            infowindow.setContent(marker.html);
                            infowindow.close();
                            infowindow.open(map, marker);
                        });      
                        marker2 = new google.maps.Marker({                       
                            position: new google.maps.LatLng(43.014802, - 81.212926),
                            map: map,
                            animation: google.maps.Animation.DROP,
                            icon: `../images/marker2.png`,
                            title: `Some hover info goes here`,
                            html: `<div> 1181 Highbury Ave N <br/> London , ON <br/> 0.35 mi </div>`
                        });
                        google.maps.event.addListener(marker2, "click", () => {
                            infowindow.setContent(marker2.html);
                            infowindow.close();
                            infowindow.open(map, marker2);
                        });  
                        marker3 = new google.maps.Marker({       
                            position: new google.maps.LatLng(42.984459, -81.289962),
                            map: map,
                            animation: google.maps.Animation.DROP,
                            icon: `../images/marker3.png`,
                            title: `Some hover info goes here`,
                            html: `<div>Store#103 <br/> Fanshawe Park Road East, London <br/> 0.2 mi </div>`
                        });
                        google.maps.event.addListener(marker3, "click", () => {
                            infowindow.setContent(marker3.html);
                            infowindow.close();
                            infowindow.open(map, marker3);
                        });                       
                    }
                });
            } catch (error) {
                console.log(error);
            }
        }
    },
    data: {
        details: [],
        lat: '',
        lng: '',
        showModal: false
    }
});