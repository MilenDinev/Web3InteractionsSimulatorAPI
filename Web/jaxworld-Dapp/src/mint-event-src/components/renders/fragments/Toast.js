import { ToastContainer, toast } from 'react-toastify';
import { TOAST } from '../../constants/toast.ts';

export function Toast() {
  const submit = () =>
    toast.info(TOAST.submit, {
      position: 'bottom-center',
      autoClose: TOAST.autoCloseSubmit,
      hideProgressBar: false,
      closeOnClick: true,
      pauseOnHover: true,
      draggable: true,
      progress: undefined,
      theme: 'light',
    });

  const success = (event) =>
    toast.success(TOAST.success, {
      position: 'bottom-center',
      autoClose: TOAST.autoCloseSuccess,
      hideProgressBar: false,
      closeOnClick: true,
      pauseOnHover: true,
      draggable: true,
      progress: undefined,
      theme: 'light',
    });

  const error = () =>
    toast.error(TOAST.error, {
      position: 'bottom-center',
      autoClose: TOAST.autoCloseError,
      hideProgressBar: false,
      closeOnClick: true,
      pauseOnHover: true,
      draggable: true,
      progress: undefined,
      theme: 'light',
    });

  const toastContainer = (
    <ToastContainer
      position="bottom-center"
      autoClose={TOAST.autoCloseGeneral}
      hideProgressBar={false}
      newestOnTop={true}
      closeOnClick
      rtl={false}
      pauseOnFocusLoss
      draggable
      pauseOnHover
      theme="light"
    />
  );

  return {
    submit,
    success,
    error,
    toastContainer,
  };
}
