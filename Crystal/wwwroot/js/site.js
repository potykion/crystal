// Write your Javascript code.

function setLanguage(language) {
    $.cookie(".AspNetCore.Culture", `c=${language}|uic=${language}`, {expires: 365, path: '/'});
}

$(
    function () {
        $("#eng").click(function (e) {
            e.preventDefault();
            setLanguage("en");
            location.reload();
        });

        $("#ru").click(function (e) {
            e.preventDefault();
            setLanguage("ru");
            location.reload();
        });
    }
);
