import React from 'react'
import MessageContainer from './MessageContainer'
import SendMessage from './SendMessage'

export default function Chat({messages,sendMessage}) {


  return (
    <div className='chat'>
        <MessageContainer messages = {messages}/>
        <SendMessage sendMessage={sendMessage}/>
    </div>
  )
}
