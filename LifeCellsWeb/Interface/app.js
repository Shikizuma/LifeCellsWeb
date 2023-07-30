let api = window.chrome.webview.hostObjects.apiwebcontroller;

var app = new Vue({
    el: "#app",
    data: {
        currentCell: null,
        cells: [],
    },
    mounted() {
        api.LoadCells();
    },
    methods: {
        viewDetails() {
          
           this.currentCell = 1;
        },
        hideDetails() {
            this.currentCell = null;
        },
        loadCells(cells) {
            this.cells = cells;
        },
    },
   
})


