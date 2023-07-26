let host = window.chrome.webview.hostObjects.apiwebcontroller;

setTimeout(() => {
    host.Test();
}, 1);

host.addEventListener('webmessage', event => {
    console.log(event)
});