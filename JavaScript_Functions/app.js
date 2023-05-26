console.log("Hello World!\n==========\n");

// Exercise 1 Section
console.log("EXERCISE 1:\n==========\n");
function printOdds(count = 0) {
    if (count < 0) count = count * -1;
    for (let i = 0; i <= count; i++) {
        if (i % 2 != 0) console.log(i);
    }
}
printOdds(-49);

// Exercise 2 Section
console.log("EXERCISE 2:\n==========\n");
function checkAge(userName = "John", age = 0) {
    let aboveSixteen = "Congrats " + userName + ", you can drive!";
    let belowSixteen = "Sorry " + userName + ", but you need to wait until you're 16 to drive.";
    if (age >= 16) {
        console.log(aboveSixteen);
    }
    else {
        console.log(belowSixteen);
    }
}
checkAge();
checkAge("Morgan", 22);

// Exercise 3 Section
console.log("EXERCISE 3:\n==========\n");
function whichQuadrant(x = 0, y = 0) {
    let point = "(" + x + ", " + y + ") ";
    if (x == 0 && y == 0) {
        console.log(point + "is the origin.");
    }
    else if (x == 0 && y != 0) {
        console.log(point + "is on the y axis.");
    }
    else if (x != 0 && y == 0) {
        console.log(point + "is on the x axis.");
    }
    else if (x > 0 && y > 0) {
        console.log(point + "is in Quadrant 1.");
    }
    else if (x < 0 && y > 0) {
        console.log(point + "is in Quadrant 2.");
    }
    else if (x < 0 && y < 0) {
        console.log(point + "is in Quadrant 3.");
    }
    else if (x > 0 && y < 0) {
        console.log(point + "is in Quadrant 4.");
    }
    else {
        console.log("I don't know where " + point + "is.");
    }
}
whichQuadrant();
whichQuadrant(0, 1);
whichQuadrant(1);
whichQuadrant(1, 1);
whichQuadrant(-1, 20);
whichQuadrant(-2342.222, -342.231);
whichQuadrant(1, -23);
whichQuadrant("szechuan", "sauce");

// Exercise 4 Section
console.log("EXERCISE 4:\n==========\n");
function triangleType(a = 0, b = 0, c = 0) {
    let sides = "Sides " + a + ", " + b + ", " + c + " ";
    if (a + b <= c || a + c <= b || b + c <= a) {
        console.log(sides + "make an invalid triangle.");
    }
    else if (a == b && b == c && a == c) {
        console.log(sides + "make an equilateral triangle.");
    }
    else if (a == b || b == c || a == c) {
        console.log(sides + "make an isosceles triangle.");
    }
    else if (a != b && b != c && a != c) {
        console.log(sides + "make a scalene triangle.");
    }
    else {
        console.log(sides + "don't make a triangle.");
    }
}
triangleType();
triangleType(3, 3, 9);
triangleType(2, 2, 2);
triangleType(9, 9, 12);
triangleType(3, 4, 5);
triangleType("cheese", "bread", "butter");

// Exercise 5 Section
console.log("EXERCISE 5:\n==========\n");
function dataStatus(planLimit = 30, day = 1, usage = 0) {
    while (day > 30) day -= 30;
    let recDailyUse = planLimit / 30;
    let avgDailyUse = usage / day;
    let daysLeft = 30 - day;
    console.log(day + " days used, " + daysLeft + " days remaining");
    console.log("Recommended average daily use: " + recDailyUse + " GB/day");
    if (usage >= planLimit) {
        console.log("You are using " + avgDailyUse + " GB/day.");
        let exceedBy = usage - planLimit;
        console.log("You have EXCEEDED your plan limit by " + exceedBy + " GB.");
        console.log("Remember that you are charged additionally for any data used past the plan limit.");
    }
    else if (avgDailyUse > recDailyUse) {
        console.log("You are using " + avgDailyUse + " GB/day which is EXCEEDING your recommended average daily use.");
        let exceedBy = (avgDailyUse * 30) - planLimit;
        console.log("If you continue using data at this rate, you will exceed your data plan by " + exceedBy + " GB.");
        let newRecUse = (planLimit - usage) / daysLeft;
        console.log("To stay below your data plan, use no more than " + newRecUse + " GB/day.");
    }
    else if (Math.round(avgDailyUse) == Math.round(recDailyUse)) {
        console.log("You are using " + avgDailyUse + " GB/day which means that you are perfectly on track with data usage.");
    }
    else {
        console.log("You are using " + avgDailyUse + " GB/day which is below your recommended average daily use.");
        let belowBy = planLimit - (avgDailyUse * 30);
        console.log("If you continue using data at this rate, you will have " + belowBy + " GB of your data plan unused.");
        let newRecUse = (planLimit - usage) / daysLeft;
        console.log("With how much data you have left, you can use " + newRecUse + " GB/day without exceeding your data limit.");
    }
}
dataStatus();
dataStatus(100, 20, 163);
dataStatus(100, 10, 50);
dataStatus(100, 45, 50);
dataStatus(100, 25, 50);