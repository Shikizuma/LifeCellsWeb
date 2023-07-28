window.chrome.webview.addEventListener('message', event => {
    //console.log(event.data);
    app.loadCells(event.data);
});