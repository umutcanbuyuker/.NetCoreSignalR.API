import React from 'react'
import MessageContainer from './MessageContainer'
import SendMessageView from './SendMessageView'


export default function Chat({messages,sendMessage}) {


  return (
    <div className='chat'>
        <MessageContainer messages = {messages}/>
        <SendMessageView sendMessage={sendMessage}/>
    </div>
  )
}
