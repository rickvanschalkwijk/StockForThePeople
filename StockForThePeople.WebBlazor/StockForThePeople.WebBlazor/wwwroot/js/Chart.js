let graphElement;


window.setup = (id, config) => {
    console.log("Hoe begint z? " + graphElement);
    let ctx = document.getElementById(id).getContext('2d');
    graphElement = new Chart(ctx, config);
    console.log("wat is z? " + graphElement);
}
window.clean = () => {
    console.log("Is z nog steeds z?" + graphElement);
    if (graphElement instanceof Chart) {

        console.log("Clean aangeroepen. z gevonden " + graphElement);
        graphElement.destroy();
        console.log("Clean aangeroepen. z gevonden? " + graphElement);
    } else {
        console.log("Blijkbaar is z iets anders dan graph");
    }
}

window.dispose = () => {
    if (graphElement instanceof Chart) {
        console.log("In de dispose van de java functie");
        graphElement.destroy();
        
    } else {
        console.log("There is no z");
    }
}