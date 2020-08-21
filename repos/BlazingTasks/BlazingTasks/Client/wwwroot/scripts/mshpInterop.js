var mshpInterop = {};

mshpInterop.showAlert = function (message) {
    alert(message);
}

mshpInterop.setDocumentTitle = function (title) {
    document.title = title;
}

mshpInterop.callDotNetCounter = function () {
    dotNetObjectRef.invokeMethodAsync('IncrementCount');
}