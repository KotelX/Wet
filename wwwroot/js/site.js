﻿function myFunction() {;
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
        var forms = document.getElementsByClassName('needs-validation');
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

function deliteSimptom(patientId, simptomId) {
    const formData = new FormData();
    formData.append('patient', patientId);
    formData.append('diagnoz', simptomId);

    if (fetch('/PatientsInfoDeliteSimptom', {
        method: 'DELETE',
        body: formData
    })) {
        console.log(simptomId + 200000);
        var btn = document.getElementById(simptomId + 200000);
        btn.remove();
    }
}

function deliteDiagnoz(patientId, diagnozId) {
    const formData = new FormData();
    formData.append('patient', patientId);
    formData.append('diagnoz', diagnozId); 

    if (fetch('/PatientsInfoDeliteDiagnoz', {
        method: 'DELETE',
        body: formData
    })) {
        console.log(diagnozId + 200000000);
        var btn = document.getElementById(diagnozId + 200000000);
        btn.remove();
    }
}
