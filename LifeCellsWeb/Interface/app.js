let host = window.chrome.webview.hostObjects.apiwebcontroller;

host.addEventListener('webmessage', event => {
    console.log(event)
});

var app = new Vue({
    el: "#app",
    data: {
        currentCell: null,
        cellList: [
            {
                id: 1,
                category: "Категория 1",
                name: "Клетка 1"
            },
            {
                id: 2,
                category: "Категория 2",
                name: "Клетка 2"
            },
        ],
    },
    methods: {
        viewDetails() {
           this.currentCell = this.cellList[0];
        },
        hideDetails() {
            this.currentCell = null;
        },
    },
   
})