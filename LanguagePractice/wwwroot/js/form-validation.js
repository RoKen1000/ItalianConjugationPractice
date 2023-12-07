$(document).ready(function () {

    $("#conj-form").on("submit", function (event) {
        event.preventDefault();

        $("#conj-form :input:not(:submit)").each(function () {
            let feminineForm;

            if (conjugations.usesEssere === true) {

                let singularConjugations = ["firstPersonSingular", "secondPersonSingular", "thirdPersonSingular"];
                let pluralConjugations = ["firstPersonPlural", "secondPersonPlural", "thirdPersonPlural"];

                if (singularConjugations.includes(this.id)) {
                    feminineForm = conjugations[this.id].slice(0, -1) + "a";
                } else if (pluralConjugations.includes(this.id)) {
                    feminineForm = conjugations[this.id].slice(0, -1) + "e";
                }
            }

            if (this.value.toLowerCase() === conjugations[this.id] || this.value.toLowerCase() === feminineForm) {
                $("small#" + this.id).html("Correct!").css("color", "green").addClass("correct-animation");
            } else {
                $("small#" + this.id).html("Incorrect. Try again.").css("color", "red").removeClass("correct-animation");
            }
        });

    })
})