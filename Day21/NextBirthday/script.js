function calculateBirthday()
{
    let dob = new Date(document.getElementById("dob").value);
    let today = new Date();
    let nextBirthday = new Date(today.getFullYear(), dob.getMonth(), dob.getDate());

    if(nextBirthday < today)
    {
        nextBirthday.setFullYear(today.getFullYear() + 1);
    }

    let diff = nextBirthday - today;
    let days = Math.ceil(diff / (1000 * 60 * 60 * 24));

    document.getElementById("result").innerHTML =
    "Days Remaining: " + days;
}