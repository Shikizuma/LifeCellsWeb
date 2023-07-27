window.chrome.webview.addEventListener('message', event => {
    app.setPosition(event.data)
});