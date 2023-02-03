const slider = document.querySelector(".slider");
const slider2 = document.querySelector(".slider2");
const btnLeft = document.getElementById("moveLeft");
const btnLeft2 = document.getElementById("moveLeft2");
const btnRight = document.getElementById("moveRight");
const btnRight2 = document.getElementById("moveRight2");
const indicators = document.querySelectorAll(".indicator");

let baseSliderWidth = slider.offsetWidth;
let activeIndex = 0; // the current page on the slider




// Update the indicators that show which page we're currently on
function updateIndicators(index) {
    indicators.forEach((indicator) => {
        indicator.classList.remove("active");
    });
    let newActiveIndicator = indicators[index];
    newActiveIndicator.classList.add("active");
}

// Scroll Left button
btnLeft.addEventListener("click", (e) => {
    let movieWidth = document.querySelector(".movie").getBoundingClientRect().width;
    let scrollDistance = movieWidth * 6; // Scroll the length of 6 movies. TODO: make work for mobile because (4 movies/page instead of 6)

    slider.scrollBy({
        top: 0,
        left: -scrollDistance,
        behavior: "smooth",
    });
    activeIndex = (activeIndex - 1) % 3;
    console.log(activeIndex);
    updateIndicators(activeIndex);
});

// Scroll Right button
btnRight.addEventListener("click", (e) => {
    let movieWidth = document.querySelector(".movie").getBoundingClientRect()
        .width;
    let scrollDistance = movieWidth * 6; // Scroll the length of 6 movies. TODO: make work for mobile because (4 movies/page instead of 6)

    console.log(`movieWidth = ${movieWidth}`);
    console.log(`scrolling right ${scrollDistance}`);

    // if we're on the last page
    if (activeIndex == 2) {
        // duplicate all the items in the slider (this is how we make 'looping' slider)
        populateSlider();
        slider.scrollBy({
            top: 0,
            left: +scrollDistance,
            behavior: "smooth",
        });
        activeIndex = 0;
        updateIndicators(activeIndex);
    } else {
        slider.scrollBy({
            top: 0,
            left: +scrollDistance,
            behavior: "smooth",
        });
        activeIndex = (activeIndex + 1) % 3;
        console.log(activeIndex);
        updateIndicators(activeIndex);
    }
});







// Scroll Left button
btnLeft2.addEventListener("click", (e) => {
    let movieWidth = document.querySelector(".movie").getBoundingClientRect().width;
    let scrollDistance = movieWidth * 6; // Scroll the length of 6 movies. TODO: make work for mobile because (4 movies/page instead of 6)

    slider2.scrollBy({
        top: 0,
        left: -scrollDistance,
        behavior: "smooth",
    });
    activeIndex = (activeIndex - 1) % 3;
    console.log(activeIndex);
    updateIndicators(activeIndex);
});

// Scroll Right button
btnRight2.addEventListener("click", (e) => {
    let movieWidth = document.querySelector(".movie").getBoundingClientRect()
        .width;
    let scrollDistance = movieWidth * 6; // Scroll the length of 6 movies. TODO: make work for mobile because (4 movies/page instead of 6)

    console.log(`movieWidth = ${movieWidth}`);
    console.log(`scrolling right ${scrollDistance}`);

    // if we're on the last page
    if (activeIndex == 2) {
        // duplicate all the items in the slider (this is how we make 'looping' slider)
        populateSlider();
        slider2.scrollBy({
            top: 0,
            left: +scrollDistance,
            behavior: "smooth",
        });
        activeIndex = 0;
        updateIndicators(activeIndex);
    } else {
        slider2.scrollBy({
            top: 0,
            left: +scrollDistance,
            behavior: "smooth",
        });
        activeIndex = (activeIndex + 1) % 3;
        console.log(activeIndex);
        updateIndicators(activeIndex);
    }
});