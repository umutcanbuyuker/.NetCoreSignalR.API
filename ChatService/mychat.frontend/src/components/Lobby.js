import React from 'react'
import { Button, Form, FormGroup } from "react-bootstrap"
import { useState } from "react";

export default function Lobby({ joinRoom }) {
    const [user, setUser] = useState();
    const [room, setRoom] = useState();

  return (
    <>
        <Form className='lobby'
     onSubmit = {e =>{
        e.preventDefault();
        joinRoom(user,room);
    }}>

 
    <FormGroup>
        <Form.Control placeholder="name" onChange={e => setUser(e.target.value)} />
        <Form.Control placeholder="room" onChange={e => setRoom(e.target.value)} />
    </FormGroup>
    <Button variant='success' type='submit' disabled={!user || !room}>Join</Button>
</Form>
</>
  )
}
