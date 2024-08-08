(function () {
    //Remove os favicons padrão do Swagger
    var link = document.querySelector("link[rel*='icon']") || document.createElement('link');
    document.head.removeChild(link);
})();