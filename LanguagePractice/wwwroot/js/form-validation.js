$(document).ready(function () {

    $("#conj-form").on("submit", function (event) {
        event.preventDefault();

        $("#conj-form :input:not(:submit)").each(function () {
            if (conjugations.usesEssere === true) {

                let singularConjugations = ["firstPersonSingular", "secondPersonSingular", "thirdPersonSingular"];
                let pluralConjugations = ["firstPersonPlural", "secondPersonPlural", "thirdPersonPlural"];

                if (singularConjugations.includes(this.id)) {

                    let feminineFormSingular = conjugations[this.id].slice(0, -1) + "a";

                    if (this.value.toLowerCase() === conjugations[this.id] || this.value.toLowerCase() === feminineFormSingular) {
                        $("small#" + this.id).html("Correct!").css("color", "green");
                    } else {
                        $("small#" + this.id).html("Incorrect. Try again.").css("color", "red");
                    }
                } else if (pluralConjugations.includes(this.id)) {

                    let feminineFormPlural = conjugations[this.id].slice(0, -1) + "e";

                    if (this.value.toLowerCase() === conjugations[this.id] || this.value.toLowerCase() === feminineFormPlural) {
                        $("small#" + this.id).html("Correct!").css("color", "green");
                    } else {
                        $("small#" + this.id).html("Incorrect. Try again.").css("color", "red");
                    }
                }

            }
            else {
                if (this.value.toLowerCase() === conjugations[this.id]) {
                    $("small#" + this.id).html("Correct!").css("color", "green");
                } else {
                    $("small#" + this.id).html("Incorrect. Try again.").css("color", "red");
                }
            }
        });

    })
})