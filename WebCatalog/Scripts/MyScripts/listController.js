app.controller('listController', function ($scope, $location, SPACRUDService, ShareData) {
    loadAllStudentsRecords();

    function loadAllStudentsRecords() {
        var promiseGetStudent = SPACRUDService.getStudents();

        promiseGetStudent.then(function (pl) { $scope.Students = pl.data },
            function (errorPl) {
                $scope.error = errorPl;
            });
    }

    //To Edit Student Information  
    $scope.editStudent = function (StudentID) {
        ShareData.value = StudentID;
        $location.path("/home");
    };

});  