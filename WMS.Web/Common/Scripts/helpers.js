﻿var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('WMS');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);