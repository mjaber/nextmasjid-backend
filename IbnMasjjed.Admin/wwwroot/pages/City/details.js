
var app = new Vue({
    el: '#app',
    data: {
        city: null,
        map: null,
        polygone: [],
        kml: ''
    },
    mounted() {
        
        this.city = JSON.parse(_city);
        var _center = { lat: 26.0634171, lng: 44.1450777 };
        this.map = new google.maps.Map(document.getElementById('map'), { zoom: 10, center: _center });

        this.getCityPolygon();

    },
    methods: {
        getCityPolygon: function () {
            var _this = this;
            axios({
                method: 'get',
                url: "/city/" + _this.city.Id + "/polygon"// "@Url.Action("ActiveCapten", "Resources")"
            }).then(response => {
                var _rspns = response.data.result;
                if (_rspns.isSuccess) {
                    _this.polygone = _rspns.data;
                }

            }).catch(error => {
                _this.showError("حدث خطأ غير معروف في النظام، يرجى تحديث الصفحة");
                //TODO : handle error
            });
        },
        fileSelected: function () {
            
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
            
            var _this = this;
            axios({
                method: 'post',
                url: "/city/" + _this.city.Id + "/polygon",// "@Url.Action("ActiveCapten", "Resources")"
                data: {
                    cityId: _this.city.Id,
                    xml: _this.kml
                }
            }).then(response => {
                debugger
                /*var _rspns = response.data.result;
                if (_rspns.isSuccess) {
                    _this.polygone = _rspns.data;
                }*/

            }).catch(error => {
                _this.showError("حدث خطأ غير معروف في النظام، يرجى تحديث الصفحة");
            });

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