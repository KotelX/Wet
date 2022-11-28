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

$('#activeDiagnozs div label, #unactiveDiagnozs div label').click(function () {
    var label = $(this);
    if (!$('#' + this.htmlFor).is(':checked')) {
        label.children('svg').html('<i class="fa-regular fa-trash-can"></i>');
        label.parent().addClass('border-2 border-danger border');
        label.parent().remove(label.parent());
        $('#activeDiagnozs').append(label.parent());
    }
    else {
        label.children('svg').html('<i class="fa-solid fa-plus"></i>');
        label.parent().removeClass('border-2 border-danger border');
        label.parent().remove(label.parent());
        $('#unactiveDiagnozs').append(label.parent());
    }
});

$('#activeSimptoms div label, #unactiveSimptoms div label').click(function () {
    var label = $(this);
    if (!$('#' + this.htmlFor).is(':checked')) {
        label.children('svg').html('<i class="fa-regular fa-trash-can"></i>');
        label.parent().addClass('border-2 border-danger border');
        label.parent().remove(label.parent());
        $('#activeSimptoms').append(label.parent());
    }
    else {
        label.children('svg').html('<i class="fa-solid fa-plus"></i>');
        label.parent().removeClass('border-2 border-danger border');
        label.parent().remove(label.parent());
        $('#unactiveSimptoms').append(label.parent());
    }
});

$('#filterDiagnozs').keyup(function () {

    var rex = new RegExp($(this).val(), 'i');
    $('#unactiveDiagnozs > div').removeClass("d-inline-block");
    $('#unactiveDiagnozs > div').hide();
    $('#unactiveDiagnozs div label').filter(function () {
        return rex.test($(this).text());
    }).parent().addClass("d-inline-block").show();

});

$('#filterSimptoms').keyup(function () {

    var rex = new RegExp($(this).val(), 'i');
    $('#unactiveSimptoms > div').removeClass("d-inline-block");
    $('#unactiveSimptoms > div').hide();
    $('#unactiveSimptoms div label').filter(function () {
        return rex.test($(this).text());
    }).parent().addClass("d-inline-block").show();

});