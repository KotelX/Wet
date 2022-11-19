function myFunction() {;
    var input = $('#number')[0].value;
    var tr = $("#tabble_main tr");
    for (i = 1; i < tr.length; i++)
    {
        td = tr[i].getElementsByTagName("th")[0];
        if (td)
        {
            if (td.textContent.localeCompare(input) && input)
            {
                tr[i].style.display = "none";
            }
            else
            {
                tr[i].style.display = "";
            }
        }
    }
}

function httpGet(number) {
    location.replace("?number=" + number);
}
(function () {
    'use strict';
    window.addEventListener('load', function () {
        // Получите все формы, к которым мы хотим применить пользовательские стили проверки Bootstrap
        var forms = document.getElementsByClassName('needs-validation');
        // Зацикливайтесь на них и предотвращайте подчинение
        var validation = Array.prototype.filter.call(forms, function (form) {
            form.addEventListener('submit', function (event) {
                if (form.checkValidity() === false) {
                    event.preventDefault();
                    event.stopPropagation();
                }
                form.classList.add('was-validated');
            }, false);
        });
    }, false);
})();