myApp.controller('STIController', ['$scope', '$rootScope', '$http', '$filter' , 'NgTableParams', function ($scope, $rootScope, $http, $filter, NgTableParams) {
    var stiWithSTKParameters = {
        CommodityCode: '1',
        StartDate: '',
        EndDate: ''
    };

    $scope.setDefaultDate = function () {
        var startDate = '01.01.2016';
        var endDate = '01.01.2018';
        $("#dtpStartDate").datepicker({
            format: 'dd.MM.yyyy'
        }).val(startDate);
        $("#dtpEndDate").datepicker({
            format: 'dd.MM.yyyy'
        }).val(endDate);
    }

    $scope.changeDate = function (date) {
        return $filter("date")(date, 'dd.MM.yyyy');
    }

    $scope.loadStiList = function () {
        stiWithSTKParameters.CommodityCode = $('#txtCommodityCode').val();
        stiWithSTKParameters.StartDate = $('#dtpStartDate').val();
        stiWithSTKParameters.EndDate = $('#dtpEndDate').val();
        $http({
            method: "POST",
            url: "/STI/GetStiList",
            headers: { "Content-Type": "Application/json;charset=utf-8" },
            data: { stiWithSTKParameter: stiWithSTKParameters }
        }).then(function (response) {
            $scope.stiList = response.data;
            $scope.tableStiParams = new NgTableParams({
            },
                {
                    filterDelay: 0,
                    counts: [10, 20, 50, 100],
                    dataset: angular.copy(response.data)
                });
        });
    }

    $(document).ready(function () {
        $scope.setDefaultDate();
        $scope.loadStiList();
    });
}]);