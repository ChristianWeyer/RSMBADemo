rs.tracksApp.controller("tracksController", function ($scope, $http) {

    $http.get("../api/tracks/list").then(function(result) {
        $scope.tracks = result.data;
    }, function(error) {
        
    });

    $scope.selectTrack = function(track) {
        alert(track.Id);
    };
});