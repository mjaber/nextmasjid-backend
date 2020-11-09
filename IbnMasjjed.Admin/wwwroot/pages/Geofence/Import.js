
import { getAllCities } from '../lookup/lookup.js';


var app = new Vue({
    el: '#app',
    data: {
        citys: null,
        map: null,
        cityGeofence: [],
        kml: '',
        selectedPolygon:null
    },
    mounted() {

        var _center = { lat: 26.0634171, lng: 44.1450777 };
        this.map = new google.maps.Map(document.getElementById('map'), { zoom: 10, center: _center });
        this.getCities();
    },
    methods: {
        getCities: function () {
            var _this = this;
            getAllCities().then(response => {
                _this.citys = response.data;

            }).catch(error => {
                _this.showError("حدث خطأ غير معروف في النظام، يرجى تحديث الصفحة");
            });

        },
        removeCitygeofince: function (i) {
            this.cityGeofence.splice(i, 1);
            this.clearMap();
        },
        viewPolygon: function (geo) {

            if (this.selectedPolygon) {
                this.selectedPolygon.setMap(null);
                this.selectedPolygon = null;
            }
           

            const coords = [];

            for (var i = 0; i < geo.points.length; i++) {
                coords.push({
                    lat: geo.points[i].latitude,
                    lng: geo.points[i].longitude
                });
            }


            this.selectedPolygon = new google.maps.Polygon({
                paths: coords,
                strokeColor: "#FF0000",
                strokeOpacity: 0.8,
                strokeWeight: 2,
                fillColor: "#FF0000",
                fillOpacity: 0.35
            });

            this.selectedPolygon.setMap(this.map);

            this.map.setCenter(coords[0]);

        },
        clearMap: function () {
            //todo : clean the map from ever item
        },
        fileSelected: function () {

            this.kml = '';

            if (!this.$refs.kmlFileInput.files || this.$refs.kmlFileInput.files.length == 0) {
                this.showError("يرجى اختيار الملف");
                return;
            }

            var _kmlFile = this.$refs.kmlFileInput.files[0];
            var ext = _kmlFile.name.split('.').pop().toLowerCase();

            if (ext != "kml") {
                this.showError("الرجاء التأكد من اختيار ملف kml  فقط");
                return;
            }

            var _this = this;
            var reader = new FileReader();
            reader.addEventListener('load', function (e) {
                _this.kml = e.target.result;
            });

            reader.readAsBinaryString(_kmlFile);
        },
        saveKml: function () {
            if (this.kml == '') {
                this.showError("يرجى اختيار الملف");
                return;
            }

            var _this = this;
            axios({
                method: 'post',
                url: "/Geofence/import",
                data: {
                    kml: _this.kml
                }
            }).then(response => {
                
                if (response.data.isSuccess) {
                    _this.cityGeofence = response.data.result;
                }
                else {
                    this.showError(response.data.message);
                }
              
            }).catch(error => {
                _this.showError("حدث خطأ غير معروف في النظام، يرجى تحديث الصفحة");
            });

            $('#addKmlDialog').modal('hide');
        },
        showError: function (err) {
            $(document).Toasts('create', {
                class: 'bg-danger',
                title: 'رسالة خطأ',
                subtitle: 'انتبه',
                body: err
            })
        }
    }//end methods
})

//$('#addKmlDialog').modal('hide')