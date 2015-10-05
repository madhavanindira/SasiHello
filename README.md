
# cordova SasiHello
This plugin defines a global `hello` object, which describes the device's hardware and software.
Although the object is in the global scope, it is not available until after the `deviceready` event.

    document.addEventListener("deviceready", onDeviceReady, false);
    function onDeviceReady() {
        console.log(hello.cordova);
    }

## Installation

    cordova plugin add SasiHello
