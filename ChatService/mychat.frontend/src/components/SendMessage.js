import React, { useState } from 'react'
import { Button, FormControl, InputGroup, Form } from 'react-bootstrap'

export default function SendMessage({sendMessage}) {
    const [message,setMessage] = useState('');
  return (
    <>
        <Form
        onSubmit={e => {
            e.preventDefault();
            sendMessage(message);
            setMessage('');
        }}>
            <InputGroup>
            <FormControl placeholder='message...'
            onChange={e => setMessage(e.target.value)} value={message}/>
            <InputGroup.Append>
            <Button variant='primary' type='submit'
            disabled={!message}>Send</Button>
            </InputGroup.Append>
            </InputGroup>
        </Form>
    </>
  )
}
