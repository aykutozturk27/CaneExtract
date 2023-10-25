myApp.controller('StiController', ['$scope', '$rootScope', '$http', '$filter' , 'NgTableParams', function ($scope, $rootScope, $http, $filter, NgTableParams) {
    $scope.stiWithSTKParameter = {
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

    $scope.changeDate = function (input) {
        return $filter("date")(new Date(input), 'dd.MM.yyyy');
    }

    $scope.loadStiList = function () {
        $scope.stiWithSTKParameter.CommodityCode = $('#txtCommodityCode').val();
        $scope.stiWithSTKParameter.StartDate = $('#dtpStartDate').val();
        $scope.stiWithSTKParameter.EndDate = $('#dtpEndDate').val();
        $http({
            method: "POST",
            url: "/STI/GetStiList",
            headers: { "Content-Type": "Application/json;charset=utf-8" },
            params: $scope.stiWithSTKParameter 
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