
# cordova SasiHello
This plugin defines a global `SasiHello` object, which describes the device's hardware and software.
Although the object is in the global scope, it is not available until after the `deviceready` event.

    var success = function (message) {
        alert(message);
    }

    var failure = function () {
        alert("Error calling SasiHello Plugin");
    }

    hello.greet("World", success, failure);

## Installation

    cordova plugin add SasiHello
