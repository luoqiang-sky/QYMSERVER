var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('QYMSERVER');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);