let api = window.chrome.webview.hostObjects.apiwebcontroller;

var app = new Vue({
    el: "#app",
    data: {
        currentCell: null,
        coordinates: {
            left: "100px",
            top: "100px",
        },
    },
    methods: {
        viewDetails() {
           api.GetPosition();
          /*this.currentCell = this.cellList[0];*/
        },
        hideDetails() {
            this.currentCell = null;
        },
        setPosition(point) {
            this.coordinates = point;
        },
    },
   
})


