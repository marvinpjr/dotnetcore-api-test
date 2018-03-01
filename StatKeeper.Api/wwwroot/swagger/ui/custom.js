(function () {
    document.title = "StatKeeper Api";

    var logo = document.getElementById('logo');
    logo.href = "http://www.marvinpalmer.com";

    var logoImg = document.getElementsByClassName('logo__img')[0];
    logoImg.alt = "Stat Keeper Api";
    logoImg.src = "/swagger/ui/clipboard.png";
    logoImg.width = 30;

    var logoTitle = document.getElementsByClassName('logo__title')[0];
    logoTitle.innerHTML = "Stat Keeper Api";
})();