function calculateExperience()
{
    let doj = new Date(document.getElementById("doj").value);
    let today = new Date();
    let years = today.getFullYear() - doj.getFullYear();
    if(today.getMonth() < doj.getMonth() || (today.getMonth() == doj.getMonth() && today.getDate() < doj.getDate()))
    {
      years--;
    }
    document.getElementById("result").innerHTML =
    "Experience: " + years + " Years";
}