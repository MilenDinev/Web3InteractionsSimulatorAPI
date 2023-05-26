import Spinner from "react-bootstrap/Spinner";

export function Loading() {
  return (
    <>
      <Spinner animation="border" variant="secondary" size="sm">
        <span className="visually-hidden">Loading...</span>
      </Spinner>
    </>
  );
}
