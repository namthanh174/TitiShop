(function (app) {
    app.controller('productEditController', productEditController);

    productEditController.$inject = ['$scope', 'apiService', 'notificationService', '$state', 'commonService','$stateParams'];

    function productEditController($scope, apiService, notificationService, $state, commonService, $stateParams) {

        $scope.moreImages = [];
        $scope.product = {
            UpdatedDate: new Date(),
        }

        $scope.ckeditorOptions = {
            language: 'vi',
            height: '200px'
        }
        

        $scope.UpdateProduct = UpdateProduct;
        $scope.GetSeoTitle = GetSeoTitle;

        function GetSeoTitle() {
            $scope.product.Alias = commonService.getSeoTitle($scope.product.Name);
        }


        loadProductDetail();
        function loadProductDetail() {
            apiService.get('api/product/getbyid/' + $stateParams.id, null, function (result) {
                $scope.product = result.data;
                $scope.moreImages = JSON.parse($scope.product.MoreImage);
            }, function (error) {
                notificationService.displayError(error.data);
            });
        }

        function UpdateProduct() {
            $scope.product.MoreImage = JSON.stringify($scope.moreImages);
            apiService.put('api/product/update', $scope.product, function (result) {
                notificationService.displaySuccess(result.data.Name + ' đã được cập nhật.');
                $state.go('products');
            }, function (error) {
                notificationService.displayError('Cập nhật không thành công');
            });
        }



        $scope.parentCategories = [];

        function loadProductCategory() {
            apiService.get('api/productcategory/getallparents', null, function (result) {
                $scope.productCategories = result.data;
            }, function () {
                console.log("Can not get list prodictcategory.");
            });
        }
        $scope.ChooseImage = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $scope.$apply(function(){
                    $scope.product.Image = fileUrl;
                });
               
            }

            finder.popup();
        }
       
        $scope.ChooseMoreImage = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $scope.$apply(function () {
                    $scope.moreImages.push(fileUrl);
                })
            };
            finder.popup();
        }


        loadProductCategory();
    }
})(angular.module('titishop.products'));