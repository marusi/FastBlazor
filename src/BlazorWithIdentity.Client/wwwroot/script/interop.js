window.interop = {
    setProperty: function (name, value) {
        window.localStorage[name] = value;
        return value;
    },
    getProperty: function (name) {
        return window.localStorage[name];
    },
    setFocus: function (element) {
        element.focus();
       
    },
    watch: function (instance) {
        window.addEventListener('storage', function (e) {
            console.log('storage event');
            instance.invokeMethodAsync('UpdateCounter');
        });
    }
};

window.displayTickerAlert = (symbol, price) => {
    alert(`${symbol}: $${price}!`);
};