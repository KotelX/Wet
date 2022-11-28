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

//function deliteDiagnoz(patientId, diagnozId) {
//    const formData = new FormData();
//    formData.append('patient', patientId);
//    formData.append('diagnoz', diagnozId); 

//    if (fetch('/PatientsInfoDeliteDiagnoz', {
//        method: 'DELETE',
//        body: formData
//    })) {
//        console.log(diagnozId + 200000000); //73 страка для вытягивания
//        var btn = document.getElementById(diagnozId + 200000000); //&('diagnozId + 200000000')
//        btn.remove();
//    }
//}

$('#deltiteDiagnoz div button').click(function () {
    const formData = new FormData();
    formData.append('patient', $('#deltiteDiagnoz div input')[0].value); 
    formData.append('diagnoz', $('#deltiteDiagnoz div input')[1].value);

    console.log('patient', $('#deltiteDiagnoz div input')[0].value);
    console.log('diagnoz', $('#deltiteDiagnoz div input')[1].value);
    $.ajax({
        url: '/PatientsInfoDeliteDiagnoz',
        type: 'DELETE',
        data: formData,
        processData: false,
        success: function (result) {
            var element = $($('#deltiteDiagnoz div input')[1].value +'200000000');
            console.log(element.text());
            if (!$('#' + this.htmlFor).is(':checked')) {
                element.removeClass("d-inline-block");
                element.hide();
                element.remove();
        }
        }
    });

    //if (fetch('/PatientsInfoDeliteDiagnoz', {
    //    method: 'DELETE',
    //    body: formData
    //var btn = $('diagnozId + 200000000').append($(this).parent()); //&$('diagnozId + 200000000').append(label.parent());
    //btn.remove();
    //})) {
    //    
    //}
})

$('#activeDiagnozs div label, #unactiveDiagnozs div label').click(function () {
    var label = $(this);
    if (!$('#' + this.htmlFor).is(':checked')) { //эта
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