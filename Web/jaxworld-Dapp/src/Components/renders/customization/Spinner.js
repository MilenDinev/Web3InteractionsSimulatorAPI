import Spinner from 'react-bootstrap/Spinner';
import { LOADING } from '../../constants/loading.ts';

export function Loading() {
  return (
    <>
      <Spinner animation="border" variant="secondary" size="sm">
        <span className="visually-hidden">{LOADING.message}</span>
      </Spinner>
    </>
  );
}
