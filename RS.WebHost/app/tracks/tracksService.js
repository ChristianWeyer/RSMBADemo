
rs.tracksApp.factory("tracksService", function ($http) {
    var service = {};

    service.getTracksList = function() {
        return $http.get(rs.baseurl + "tracks/list");
    };

    service.getTrackDetails = function(trackId) {
        return $http.get(rs.baseurl + "tracks/single?id=" + trackId);
    };

    return service;
});