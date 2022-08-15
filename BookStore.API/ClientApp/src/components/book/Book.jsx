import { Wrapper } from "../ui/Wrapper";
import { BookModal } from "../Modal";
import { BookCoverImage } from "./BookCoverImage";
import { BookTitle } from "./BookTitle";

import "../book/styleBookCards.css";

export const Book = ({ book }) => {
  return (
    <Wrapper className="card-wrapper">
      <BookCoverImage image={book.imgLink} />
      <hr className="hr" />
      <Wrapper className="card-body">
        <BookTitle title={book.title} />
        <BookModal
          imgLink={book.imgLink}
          authorName={book.authorName}
          desc={book.description}
          genre={book.genreName}
          isbn={book.isbn}
          lang={book.languageName}
          pages={book.pageNumber}
          price={book.price}
          publisher={book.publisherName}
          publishingYear={book.publisherYear}
          title={book.title}
        />
      </Wrapper>
    </Wrapper>
  );
};
