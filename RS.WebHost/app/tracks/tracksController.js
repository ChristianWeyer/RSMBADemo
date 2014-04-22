rs.tracksApp.controller("tracksController", function ($scope, $location, tracksService) {

    tracksService.getTracksList().then(function(result) {
        $scope.tracks = result.data;
    }, function(error) {
        
    });

    $scope.selectTrack = function(track) {
        $location.path("/details/" + track.Id);
    };
});