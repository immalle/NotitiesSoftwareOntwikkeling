// go to about:blank
// paste this into your console

document.body.style.backgroundColor = "black";

var passedTime = {
    min: 0,
    sec: 0
}

const pomodoroMinutes = 2;
const oneSecond = 100;

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
    if(passedTime.min == pomodoroMinutes && passedTime.sec == 0) {
        document.body.style.backgroundColor = "lawngreen";
        clearInterval(tmr);
    } 
  }, oneSecond);
  