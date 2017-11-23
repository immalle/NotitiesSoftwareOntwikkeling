// go to about:blank
// paste this into your console

document.body.style.backgroundColor = "black";

var pomodoro = 15; // min
var passedTime = {
    min: 0,
    sec: 0
}

function increasePassedTime() {
    passedTime.sec += 1;
    if(passedTime.sec == 60) {
        passedTime.min += 1;
        passedTime.sec = 0;
    }
}

var tmr = setInterval(_ => {
    increasePassedTime();
    console.log(passedTime);   
    if(passedTime.min == 15 && passedTime.sec == 0) {
        document.body.style.backgroundColor = "green";
        clearInterval(tmr);
    } 
  }, 1000);
  