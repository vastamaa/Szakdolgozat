import React from 'react'

import { Wrapper } from '../ui/Wrapper'
import { Book } from './Book'

import './BooksList.css'

export const BooksList = ({ books }) => {
  return (
    <Wrapper className="book-cards-wrapper">
      {books.map((book) => (
        <Book key={book.isbn} book={book} />
      ))}
    </Wrapper>
  )
}
