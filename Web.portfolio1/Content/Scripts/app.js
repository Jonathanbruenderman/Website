angular
.module('dotsApp', ['Game'])
.controller('GameController', function (GameManager) {
    this.game = GameManager;
});