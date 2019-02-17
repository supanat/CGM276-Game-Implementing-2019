
var callback = function(param){
    console.log("do something : ",param)
}

function myFunction(param,func){
    func(param);
}

myFunction("Say",callback);