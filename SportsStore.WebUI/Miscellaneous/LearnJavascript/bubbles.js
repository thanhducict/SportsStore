var scores = [60, 50, 60, 58, 54, 54, 
    58, 50, 52, 54, 48, 69,
    34, 55, 51, 52, 44, 51,
    69, 64, 66, 55, 52, 61,
    46, 31, 57, 52, 44, 18,
    41, 53, 55, 61, 51, 44];

var i = 0;
var highestScore = 0;
var highestSolutions;

document.write("<pre>");

/*
while (i < scores.length) {
    document.writeln("Bubble solution #" + i + " score: " + scores[i]);
    i = i + 1;
}

document.writeln("Bubble test:" + scores.length);

for(i = 0; i < scores.length; i++) {
    if((highestScore < scores[i])) {
        highestScore = scores[i];
        highestSolutions = [];
        highestSolutions.push(i);
        continue;
    }
    if((highestScore == scores[i])) {
        highestSolutions.push(i);
    }
}
document.writeln("Highest bubble score: " + highestScore);

document.write("Solutions with the highest score:");
for(i = 0; i < highestSolutions.length; i++) {
    document.write("#" + highestSolutions[i]);
    if(i < highestSolutions.length - 1) {
        document.write(", ");
    }
}*/

var highScore = printAndGetHighScore(scores);
document.writeln("Bubbles tests: " + scores.length);
document.writeln("Highest bubble score: " + highScore);
var bestSolutions = getBestResults(scores, highScore);
document.writeln("Solutions with the highest score: " + bestSolutions);

document.write("</pre>");

function printAndGetHighScore(scores) {
    var highScore = 0;
    var output;
    for (var i = 0; i < scores.length; i++) {
        output = "Bubble solution #" + i + " score: " + scores[i];
        document.writeln(output);
        if (scores[i] > highScore) {
            highScore = scores[i];
        }
    }
    return highScore;
}

function getBestResults(scores, highScore) {
    var bestSolutions = [];
    for (var i = 0; i < scores.length; i++) {
        if (scores[i] == highScore) {
            bestSolutions.push(i);
        }
    }
    return bestSolutions;
}