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
        LoadCells(cells) {
            this.cells = cells;

            setInterval(() => {
                let json = JSON.stringify(this.cells);
                api.UpdateCells(json);
            }, 500)
        },
        UpdateCells(newCells) {
            this.cells = newCells;
        },
    },
   
})


