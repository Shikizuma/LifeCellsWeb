let api = window.chrome.webview.hostObjects.apiwebcontroller;

var app = new Vue({
    el: "#app",
    data: {
        currentCell: null,
        cells: [
            {

                life: 100,
                style: {
                    width: "150px",
                    height: "150px",
                    left: "100px",
                    top: "100px",
                },
                mitochondrions: [
                    {
                        style: {
                            left: "50px",
                            top: "30px",
                            transform: "rotate(100deg)",
                        },
                    },
                    {
                        style: {
                            left: "90px",
                            top: "70px",
                            transform: "rotate(5deg)",
                        },
                    },
                    {
                        style: {
                            left: "10px",
                            top: "20px",
                            transform: "rotate(90deg)",
                        },
                    },
                ],
            },
            {

                life: 100,
                style: {
                    width: "100px",
                    height: "100px",
                    left: "500px",
                    top: "300px",
                },
                mitochondrions: [
                    {
                        style: {
                            left: "50px",
                            top: "30px",
                            transform: "rotate(100deg)",
                        },
                    },
                   
                    {
                        style: {
                            left: "10px",
                            top: "20px",
                            transform: "rotate(90deg)",
                        },
                    },
                ],
            },
        ],
    },
    methods: {
        viewDetails() {
           api.GetPosition();
          /* this.currentCell = this.cellList[0];*/
        },
        hideDetails() {
            this.currentCell = null;
        },
        setPosition(point) {
            this.coordinates = point;
        },
    },
   
})


