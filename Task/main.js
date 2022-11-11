const students = [
    {
        name: "Mahmud",
        surname:"Mirzezade",
        mark:"100"
    },
    {
        name: "Ilkin",
        surname:"Qurbanov",
        mark:"100"
    },
    {
        name: "Ziya",
        surname:"Qedimli",
        mark:"100"
    },
    {
        name: "Rza",
        surname:"Rustemov",
        mark:"100"
    },
    {
        name: "Emil",
        surname:"Ceferov",
        mark:"100"
    }
]
for (let i = 0; i < students.length; i++) {
    let tr = document.createElement("tr")
    let name = document.createElement("td")
    name.innerText = students[i].name
    let surname = document.createElement("td")
    surname.innerText = students[i].surname
    let mark = document.createElement("td")
    mark.innerText = students[i].mark

    tr.append(name)
    tr.append(surname)
    tr.append(mark)
    
    document.querySelector("tbody").append(tr)
    
}
