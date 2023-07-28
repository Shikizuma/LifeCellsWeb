let api = window.chrome.webview.hostObjects.apiwebcontroller;

var app = new Vue({
    el: "#app",
    data: {
      /*  currentCell: null,*/
        cells: [],
    },
    mounted() {
        api.LoadCells();
    },
    methods: {
        viewDetails() {
          
          /* this.currentCell = this.cellList[0];*/
        },
        hideDetails() {
            /*this.currentCell = null;*/
        },
        loadCells(cells) {
            this.cells = cells;
        },
    },
   
})


