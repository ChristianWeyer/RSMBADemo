rs.tracksApp.controller("trackDetailsController", function($scope, $routeParams, $location, tracksService) {

    tracksService.getTrackDetails($routeParams.id).then(function (result) {
        $scope.track = result.data; 
    }, function(error) {
        
    });

    $scope.navigateBack = function() {
        $location.path("/list");
    }
});