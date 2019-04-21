var io = require('socket.io')(process.env.PORT || 3000);

console.log('server started');

/*
io.on('connection',function(socket){

    console.log('client connected');
    
});
*/
// back to  Unity to start client


/*
io.on('connection',function(socket){

    console.log('client connected');

    socket.on('move',function(data){

        console.log('client moved');
    });
    
});
*/


//pt2 spawned
io.on('connection',function(socket){

    console.log('client connected');

    socket.broadcast.emit('spawn');
    
    socket.on('move',function(data){

        console.log('client moved');
    });
    
});

