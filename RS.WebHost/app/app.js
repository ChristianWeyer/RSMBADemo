window.rs = window.rs || {};

rs.baseurl = "http://localhost/readsoft/api/";

rs.tracksApp = angular.module("myTracks", ["ngRoute"]);

rs.tracksApp.config(function($routeProvider) {
    $routeProvider
        .when("/list", { templateUrl: "tracks/tracksList.html", controller: "tracksController"})
        .when("/details/:id", { templateUrl: "tracks/trackDetails.html", controller: "trackDetailsController"})
        .when("/about/", { templateUrl: "about/about.html"})
        .otherwise({ redirectTo: "/list"});
});

rs.tracksApp.run(function() {
    FastClick.attach(document.body);
});