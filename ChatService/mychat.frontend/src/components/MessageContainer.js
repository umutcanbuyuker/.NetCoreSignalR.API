import React from 'react'

export default function MessageContainer({messages}) {
  return (
    <div className='message-container'>
         {messages.map((m,index)=>
         
         <div key={index} className='user-message'>
            <div className='message bg-primary'>{m.message}</div>
            <div className='from-user'>{m.user}</div>
         </div>
         )}
    </div>
  )
}
