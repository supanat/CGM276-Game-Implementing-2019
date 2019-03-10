var mysql = require('mysql');

var connection = mysql.createConnection({
    host:"localhost",
    user:"developer",
    password:"Rx123456",
    database:'game1'
});

connection.connect(function(err){
    if(err){
        console.log('error connecting',err.stack);
        return;
    }
    console.log('connected as id ',connection.threadId);
});

var player = {firstname:'Abc',
                lastname:'Xyz',
                    playername:'abx',
                        password:'123456'};

connection.query('INSERT INTO player SET ?',player,
    function(err,result){
        if(err) throw err;

        console.log(result);
});

connection.query('SELECT * FROM player',
    function(err,rows,fields){
        if(err) throw err;

        for(var i in rows){
            console.log(rows[i].playername)
        }
});


connection.end(function(err){
    console.log('terminated connection');
});

console.log('server is running');