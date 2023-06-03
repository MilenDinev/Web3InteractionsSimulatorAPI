"use strict";(self.webpackChunkjaxworld_app=self.webpackChunkjaxworld_app||[]).push([[2185],{76285:function(e,t,n){n.d(t,{CV:function(){return P},Id:function(){return j},t0:function(){return L},zv:function(){return O},uA:function(){return x},uc:function(){return Y},jb:function(){return ne},zb:function(){return S},AV:function(){return E},Ic:function(){return ue},Vs:function(){return de},kD:function(){return ee}});var r=n(93433),a=n(37762),o=n(74165),i=n(15861),s=n(29439),c=(Symbol(),Symbol()),u=Object.getPrototypeOf,l=new WeakMap,d=function(e){return e&&(l.has(e)?l.get(e):u(e)===Object.prototype||u(e)===Array.prototype)},f=function(e){var t=!(arguments.length>1&&void 0!==arguments[1])||arguments[1];l.set(e,t)},p=function(e){return"object"===typeof e&&null!==e},v=new WeakMap,h=new WeakSet,b=function(){var e=arguments.length>0&&void 0!==arguments[0]?arguments[0]:Object.is,t=arguments.length>1&&void 0!==arguments[1]?arguments[1]:function(e,t){return new Proxy(e,t)},n=arguments.length>2&&void 0!==arguments[2]?arguments[2]:function(e){return p(e)&&!h.has(e)&&(Array.isArray(e)||!(Symbol.iterator in e))&&!(e instanceof WeakMap)&&!(e instanceof WeakSet)&&!(e instanceof Error)&&!(e instanceof Number)&&!(e instanceof Date)&&!(e instanceof String)&&!(e instanceof RegExp)&&!(e instanceof ArrayBuffer)},a=arguments.length>3&&void 0!==arguments[3]?arguments[3]:function(e){switch(e.status){case"fulfilled":return e.value;case"rejected":throw e.reason;default:throw e}},o=arguments.length>4&&void 0!==arguments[4]?arguments[4]:new WeakMap,i=arguments.length>5&&void 0!==arguments[5]?arguments[5]:function(e,t){var n=arguments.length>2&&void 0!==arguments[2]?arguments[2]:a,r=o.get(e);if((null==r?void 0:r[0])===t)return r[1];var c=Array.isArray(e)?[]:Object.create(Object.getPrototypeOf(e));return f(c,!0),o.set(e,[t,c]),Reflect.ownKeys(e).forEach((function(t){if(!Object.getOwnPropertyDescriptor(c,t)){var r=Reflect.get(e,t),a={value:r,enumerable:!0,configurable:!0};if(h.has(r))f(r,!1);else if(r instanceof Promise)delete a.value,a.get=function(){return n(r)};else if(v.has(r)){var o=v.get(r),u=(0,s.Z)(o,2),l=u[0],d=u[1];a.value=i(l,d(),n)}Object.defineProperty(c,t,a)}})),c},u=arguments.length>6&&void 0!==arguments[6]?arguments[6]:new WeakMap,l=arguments.length>7&&void 0!==arguments[7]?arguments[7]:[1,1],b=arguments.length>8&&void 0!==arguments[8]?arguments[8]:function(a){if(!p(a))throw new Error("object required");var o=u.get(a);if(o)return o;var f=l[0],w=new Set,g=function(e){var t=arguments.length>1&&void 0!==arguments[1]?arguments[1]:++l[0];f!==t&&(f=t,w.forEach((function(n){return n(e,t)})))},m=l[1],y=function(e){return function(t,n){var a=(0,r.Z)(t);a[1]=[e].concat((0,r.Z)(a[1])),g(a,n)}},C=new Map,I=function(e){var t,n=C.get(e);n&&(C.delete(e),null==(t=n[1])||t.call(n))},j=Array.isArray(a)?[]:Object.create(Object.getPrototypeOf(a)),k={deleteProperty:function(e,t){var n=Reflect.get(e,t);I(t);var r=Reflect.deleteProperty(e,t);return r&&g(["delete",[t],n]),r},set:function(t,r,a,o){var i=Reflect.has(t,r),s=Reflect.get(t,r,o);if(i&&(e(s,a)||u.has(a)&&e(s,u.get(a))))return!0;I(r),p(a)&&(a=function(e){return d(e)&&e[c]||null}(a)||a);var l=a;if(a instanceof Promise)a.then((function(e){a.status="fulfilled",a.value=e,g(["resolve",[r],e])})).catch((function(e){a.status="rejected",a.reason=e,g(["reject",[r],e])}));else{!v.has(a)&&n(a)&&(l=b(a));var f=!h.has(l)&&v.get(l);f&&function(e,t){if(C.has(e))throw new Error("prop listener already exists");if(w.size){var n=t[3](y(e));C.set(e,[t,n])}else C.set(e,[t])}(r,f)}return Reflect.set(t,r,l,o),g(["set",[r],a,s]),!0}},E=t(j,k);u.set(a,E);var O=[j,function(){var e=arguments.length>0&&void 0!==arguments[0]?arguments[0]:++l[1];return m===e||w.size||(m=e,C.forEach((function(t){var n=(0,s.Z)(t,1)[0][1](e);n>f&&(f=n)}))),f},i,function(e){w.add(e),1===w.size&&C.forEach((function(e,t){var n=(0,s.Z)(e,2),r=n[0];if(n[1])throw new Error("remove already exists");var a=r[3](y(t));C.set(t,[r,a])}));return function(){w.delete(e),0===w.size&&C.forEach((function(e,t){var n=(0,s.Z)(e,2),r=n[0],a=n[1];a&&(a(),C.set(t,[r]))}))}}];return v.set(E,O),Reflect.ownKeys(a).forEach((function(e){var t=Object.getOwnPropertyDescriptor(a,e);"value"in t&&(E[e]=a[e],delete t.value,delete t.writable),Object.defineProperty(j,e,t)})),E};return[b,v,h,e,t,n,a,o,i,u,l]},w=b(),g=(0,s.Z)(w,1)[0];function m(){return g(arguments.length>0&&void 0!==arguments[0]?arguments[0]:{})}function y(e,t,n){var r,a=v.get(e);a||console.warn("Please use proxy object");var o=[],i=a[3],s=!1,c=i((function(e){o.push(e),n?t(o.splice(0)):r||(r=Promise.resolve().then((function(){r=void 0,s&&t(o.splice(0))})))}));return s=!0,function(){s=!1,c()}}var C,I=n(40918),j={ethereumClient:void 0,setEthereumClient:function(e){C=e},client:function(){if(C)return C;throw new Error("ClientCtrl has no client set")}},k=m({history:["ConnectWallet"],view:"ConnectWallet",data:void 0}),E={state:k,subscribe:function(e){return y(k,(function(){return e(k)}))},push:function(e,t){e!==k.view&&(k.view=e,t&&(k.data=t),k.history.push(e))},reset:function(e){k.view=e,k.history=[e]},replace:function(e){k.history.length>1&&(k.history[k.history.length-1]=e,k.view=e)},goBack:function(){if(k.history.length>1){k.history.pop();var e=k.history.slice(-1),t=(0,s.Z)(e,1)[0];k.view=t}},setData:function(e){k.data=e}},O={WALLETCONNECT_DEEPLINK_CHOICE:"WALLETCONNECT_DEEPLINK_CHOICE",W3M_VERSION:"W3M_VERSION",RECOMMENDED_WALLET_AMOUNT:9,isMobile:function(){return typeof window<"u"&&!(!window.matchMedia("(pointer:coarse)").matches&&!/Android|webOS|iPhone|iPad|iPod|BlackBerry|Opera Mini/.test(navigator.userAgent))},isAndroid:function(){return O.isMobile()&&navigator.userAgent.toLowerCase().includes("android")},isIos:function(){var e=navigator.userAgent.toLowerCase();return O.isMobile()&&(e.includes("iphone")||e.includes("ipad"))},isHttpUrl:function(e){return e.startsWith("http://")||e.startsWith("https://")},isArray:function(e){return Array.isArray(e)&&e.length>0},formatNativeUrl:function(e,t,n){if(O.isHttpUrl(e))return this.formatUniversalUrl(e,t,n);var r=e;r.includes("://")||(r=e.replaceAll("/","").replaceAll(":",""),r="".concat(r,"://")),this.setWalletConnectDeepLink(r,n);var a=encodeURIComponent(t);return"".concat(r,"wc?uri=").concat(a)},formatUniversalUrl:function(e,t,n){if(!O.isHttpUrl(e))return this.formatNativeUrl(e,t,n);var r=e;e.endsWith("/")&&(r=e.slice(0,-1)),this.setWalletConnectDeepLink(r,n);var a=encodeURIComponent(t);return"".concat(r,"/wc?uri=").concat(a)},wait:function(e){return(0,i.Z)((0,o.Z)().mark((function t(){return(0,o.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",new Promise((function(t){setTimeout(t,e)})));case 1:case"end":return t.stop()}}),t)})))()},openHref:function(e,t){window.open(e,t,"noreferrer noopener")},setWalletConnectDeepLink:function(e,t){localStorage.setItem(O.WALLETCONNECT_DEEPLINK_CHOICE,JSON.stringify({href:e,name:t}))},setWalletConnectAndroidDeepLink:function(e){var t=e.split("?"),n=(0,s.Z)(t,1)[0];localStorage.setItem(O.WALLETCONNECT_DEEPLINK_CHOICE,JSON.stringify({href:n,name:"Android"}))},setWeb3ModalVersionInStorage:function(){typeof localStorage<"u"&&localStorage.setItem(O.W3M_VERSION,"2.3.7")},getWalletRouterData:function(){var e,t=null==(e=E.state.data)?void 0:e.Wallet;if(!t)throw new Error('Missing "Wallet" view data');return t},getSwitchNetworkRouterData:function(){var e,t=null==(e=E.state.data)?void 0:e.SwitchNetwork;if(!t)throw new Error('Missing "SwitchNetwork" view data');return t}},W=m({userSessionId:"",events:[],connectedWalletId:void 0}),x={state:W,subscribe:function(e){return y(W.events,(function(){return e(function(e,t){var n=v.get(e);n||console.warn("Please use proxy object");var r=(0,s.Z)(n,3),a=r[0],o=r[1];return(0,r[2])(a,o(),t)}(W.events[W.events.length-1]))}))},initialize:function(){typeof crypto<"u"&&(W.userSessionId=crypto.randomUUID())},setConnectedWalletId:function(e){W.connectedWalletId=e},click:function(e){var t={type:"CLICK",name:e.name,userSessionId:W.userSessionId,timestamp:Date.now(),data:e};W.events.push(t)},track:function(e){var t={type:"TRACK",name:e.name,userSessionId:W.userSessionId,timestamp:Date.now(),data:e};W.events.push(t)},view:function(e){var t={type:"VIEW",name:e.name,userSessionId:W.userSessionId,timestamp:Date.now(),data:e};W.events.push(t)}},Z=m({selectedChain:void 0,chains:void 0,standaloneChains:void 0,standaloneUri:void 0,isStandalone:!1,isCustomDesktop:!1,isCustomMobile:!1,isDataLoaded:!1,isUiLoaded:!1,isInjectedMobile:!1,walletConnectVersion:1}),S={state:Z,subscribe:function(e){return y(Z,(function(){return e(Z)}))},setChains:function(e){Z.chains=e},setStandaloneChains:function(e){Z.standaloneChains=e},setStandaloneUri:function(e){Z.standaloneUri=e},getSelectedChain:function(){var e=j.client().getNetwork().chain;return e&&(Z.selectedChain=e),Z.selectedChain},setSelectedChain:function(e){Z.selectedChain=e},setIsStandalone:function(e){Z.isStandalone=e},setIsCustomDesktop:function(e){Z.isCustomDesktop=e},setIsCustomMobile:function(e){Z.isCustomMobile=e},setIsDataLoaded:function(e){Z.isDataLoaded=e},setIsUiLoaded:function(e){Z.isUiLoaded=e},setWalletConnectVersion:function(e){Z.walletConnectVersion=e},setIsInjectedMobile:function(e){Z.isInjectedMobile=e}},A=m({projectId:"",mobileWallets:void 0,desktopWallets:void 0,walletImages:void 0,chainImages:void 0,tokenImages:void 0,tokenContracts:void 0,standaloneChains:void 0,enableStandaloneMode:!1,enableNetworkView:!1,enableAccountView:!0,enableExplorer:!0,defaultChain:void 0,explorerExcludedWalletIds:void 0,explorerRecommendedWalletIds:void 0,termsOfServiceUrl:void 0,privacyPolicyUrl:void 0}),L={state:A,subscribe:function(e){return y(A,(function(){return e(A)}))},setConfig:function(e){var t,n,r,a;x.initialize(),S.setStandaloneChains(e.standaloneChains),S.setIsStandalone(!(null==(t=e.standaloneChains)||!t.length)||!!e.enableStandaloneMode),S.setIsCustomMobile(!(null==(n=e.mobileWallets)||!n.length)),S.setIsCustomDesktop(!(null==(r=e.desktopWallets)||!r.length)),S.setWalletConnectVersion(null!=(a=e.walletConnectVersion)?a:1),S.state.isStandalone||(S.setChains(j.client().chains),S.setIsInjectedMobile(O.isMobile()&&j.client().isInjectedProviderInstalled())),e.defaultChain&&S.setSelectedChain(e.defaultChain),O.setWeb3ModalVersionInStorage(),Object.assign(A,e)}},M=m({address:void 0,profileName:void 0,profileAvatar:void 0,profileLoading:!1,balanceLoading:!1,balance:void 0,isConnected:!1}),P={state:M,subscribe:function(e){return y(M,(function(){return e(M)}))},getAccount:function(){var e=j.client().getAccount();M.address=e.address,M.isConnected=e.isConnected},fetchProfile:function(e,t){return(0,i.Z)((0,o.Z)().mark((function n(){var r,a,i,c,u,l,d;return(0,o.Z)().wrap((function(n){for(;;)switch(n.prev=n.next){case 0:if(n.prev=0,M.profileLoading=!0,a=null!==t&&void 0!==t?t:M.address,i=null==(r=S.state.chains)?void 0:r.find((function(e){return 1===e.id})),!a||!i){n.next=16;break}return n.next=6,Promise.all([j.client().fetchEnsName({address:a,chainId:1}),j.client().fetchEnsAvatar({address:a,chainId:1})]);case 6:if(c=n.sent,u=(0,s.Z)(c,2),l=u[0],d=u[1],n.t0=d,!n.t0){n.next=14;break}return n.next=14,e(d);case 14:M.profileName=l,M.profileAvatar=d;case 16:return n.prev=16,M.profileLoading=!1,n.finish(16);case 19:case"end":return n.stop()}}),n,null,[[0,,16,19]])})))()},fetchBalance:function(e){return(0,i.Z)((0,o.Z)().mark((function t(){var n,r,a,i,s,c;return(0,o.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:if(t.prev=0,n=j.client().getNetwork(),r=n.chain,a=L.state.tokenContracts,r&&a&&(i=a[r.id]),M.balanceLoading=!0,!(s=null!==e&&void 0!==e?e:M.address)){t.next=9;break}return t.next=7,j.client().fetchBalance({address:s,token:i});case 7:c=t.sent,M.balance={amount:c.formatted,symbol:c.symbol};case 9:return t.prev=9,M.balanceLoading=!1,t.finish(9);case 12:case"end":return t.stop()}}),t,null,[[0,,9,12]])})))()},setAddress:function(e){M.address=e},setIsConnected:function(e){M.isConnected=e},resetBalance:function(){M.balance=void 0},resetAccount:function(){M.address=void 0,M.isConnected=!1,M.profileName=void 0,M.profileAvatar=void 0,M.balance=void 0}},N="https://explorer-api.walletconnect.com";function U(e,t){return D.apply(this,arguments)}function D(){return D=(0,i.Z)((0,o.Z)().mark((function e(t,n){var r;return(0,o.Z)().wrap((function(e){for(;;)switch(e.prev=e.next){case 0:return(r=new URL(t,N)).searchParams.append("projectId",L.state.projectId),Object.entries(n).forEach((function(e){var t=(0,s.Z)(e,2),n=t[0],a=t[1];a&&r.searchParams.append(n,String(a))})),e.next=5,fetch(r);case 5:return e.abrupt("return",e.sent.json());case 6:case"end":return e.stop()}}),e)}))),D.apply(this,arguments)}var R=function(e){return(0,i.Z)((0,o.Z)().mark((function t(){return(0,o.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",U("/w3m/v1/getDesktopListings",e));case 1:case"end":return t.stop()}}),t)})))()},T=function(e){return(0,i.Z)((0,o.Z)().mark((function t(){return(0,o.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",U("/w3m/v1/getMobileListings",e));case 1:case"end":return t.stop()}}),t)})))()},V=function(e){return(0,i.Z)((0,o.Z)().mark((function t(){return(0,o.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",U("/w3m/v1/getInjectedListings",e));case 1:case"end":return t.stop()}}),t)})))()},_=function(e){return(0,i.Z)((0,o.Z)().mark((function t(){return(0,o.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",U("/w3m/v1/getAllListings",e));case 1:case"end":return t.stop()}}),t)})))()},B=function(e){return"".concat(N,"/w3m/v1/getWalletImage/").concat(e,"?projectId=").concat(L.state.projectId)},z=function(e){return"".concat(N,"/w3m/v1/getAssetImage/").concat(e,"?projectId=").concat(L.state.projectId)},H=Object.defineProperty,K=Object.getOwnPropertySymbols,J=Object.prototype.hasOwnProperty,q=Object.prototype.propertyIsEnumerable,F=function(e,t,n){return t in e?H(e,t,{enumerable:!0,configurable:!0,writable:!0,value:n}):e[t]=n},G=function(e,t){for(var n in t||(t={}))J.call(t,n)&&F(e,n,t[n]);if(K){var r,o=(0,a.Z)(K(t));try{for(o.s();!(r=o.n()).done;){n=r.value;q.call(t,n)&&F(e,n,t[n])}}catch(i){o.e(i)}finally{o.f()}}return e},Q=O.isMobile(),X=m({wallets:{listings:[],total:0,page:1},injectedWallets:[],search:{listings:[],total:0,page:1},recomendedWallets:[]}),Y={state:X,getRecomendedWallets:function(){return(0,i.Z)((0,o.Z)().mark((function e(){var t,n,r,a,i,s,c,u,l,d,f,p,v,h,b;return(0,o.Z)().wrap((function(e){for(;;)switch(e.prev=e.next){case 0:if(t=L.state,n=t.explorerRecommendedWalletIds,r=t.explorerExcludedWalletIds,"NONE"!==n&&("ALL"!==r||n)){e.next=3;break}return e.abrupt("return",X.recomendedWallets);case 3:if(!O.isArray(n)){e.next=13;break}return a={recommendedIds:n.join(",")},e.next=7,_(a);case 7:i=e.sent,s=i.listings,(c=Object.values(s)).sort((function(e,t){return n.indexOf(e.id)-n.indexOf(t.id)})),X.recomendedWallets=c,e.next=31;break;case 13:if(u=S.state,l=u.standaloneChains,d=u.walletConnectVersion,f=null===l||void 0===l?void 0:l.join(","),p=O.isArray(r),v={page:1,entries:O.RECOMMENDED_WALLET_AMOUNT,chains:f,version:d,excludedIds:p?r.join(","):void 0},!Q){e.next=25;break}return e.next=22,T(v);case 22:e.t0=e.sent,e.next=28;break;case 25:return e.next=27,R(v);case 27:e.t0=e.sent;case 28:h=e.t0,b=h.listings,X.recomendedWallets=Object.values(b);case 31:return e.abrupt("return",X.recomendedWallets);case 32:case"end":return e.stop()}}),e)})))()},getWallets:function(e){return(0,i.Z)((0,o.Z)().mark((function t(){var n,a,i,s,c,u,l,d,f,p,v,h;return(0,o.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:if(n=G({},e),a=L.state,i=a.explorerRecommendedWalletIds,s=a.explorerExcludedWalletIds,c=X.recomendedWallets,"ALL"!==s){t.next=3;break}return t.abrupt("return",X.wallets);case 3:if(n.search||(c.length?n.excludedIds=c.map((function(e){return e.id})).join(","):O.isArray(i)&&(n.excludedIds=i.join(","))),O.isArray(s)&&(n.excludedIds=[n.excludedIds,s].filter(Boolean).join(",")),u=e.page,l=e.search,!Q){t.next=12;break}return t.next=9,T(n);case 9:t.t0=t.sent,t.next=15;break;case 12:return t.next=14,R(n);case 14:t.t0=t.sent;case 15:return d=t.t0,f=d.listings,p=d.total,v=Object.values(f),h=l?"search":"wallets",t.abrupt("return",(X[h]={listings:[].concat((0,r.Z)(X[h].listings),v),total:p,page:null!==u&&void 0!==u?u:1},{listings:v,total:p}));case 21:case"end":return t.stop()}}),t)})))()},getInjectedWallets:function(){return(0,i.Z)((0,o.Z)().mark((function e(){var t,n,r;return(0,o.Z)().wrap((function(e){for(;;)switch(e.prev=e.next){case 0:return e.next=2,V({});case 2:return t=e.sent,n=t.listings,r=Object.values(n),e.abrupt("return",(X.injectedWallets=r,X.injectedWallets));case 6:case"end":return e.stop()}}),e)})))()},getWalletImageUrl:function(e){return B(e)},getAssetImageUrl:function(e){return z(e)},resetSearch:function(){X.search={listings:[],total:0,page:1}}},$=m({pairingUri:"",pairingError:!1}),ee={state:$,subscribe:function(e){return y($,(function(){return e($)}))},setPairingUri:function(e){$.pairingUri=e},setPairingError:function(e){$.pairingError=e}},te=m({open:!1}),ne={state:te,subscribe:function(e){return y(te,(function(){return e(te)}))},open:function(e){return(0,i.Z)((0,o.Z)().mark((function t(){return(0,o.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",new Promise((function(t){var n=S.state,r=n.isStandalone,a=n.isUiLoaded,o=n.isDataLoaded,i=ee.state.pairingUri,s=P.state.isConnected,c=L.state.enableNetworkView;if(r?(S.setStandaloneUri(null===e||void 0===e?void 0:e.uri),S.setStandaloneChains(null===e||void 0===e?void 0:e.standaloneChains),E.reset("ConnectWallet")):null!=e&&e.route?E.reset(e.route):s?E.reset("Account"):c?E.reset("SelectNetwork"):E.reset("ConnectWallet"),a&&o&&(r||i||s))te.open=!0,t();else var u=setInterval((function(){var e=S.state,n=ee.state;e.isUiLoaded&&e.isDataLoaded&&(e.isStandalone||n.pairingUri||s)&&(clearInterval(u),te.open=!0,t())}),200)})));case 1:case"end":return t.stop()}}),t)})))()},close:function(){te.open=!1}},re=Object.defineProperty,ae=Object.getOwnPropertySymbols,oe=Object.prototype.hasOwnProperty,ie=Object.prototype.propertyIsEnumerable,se=function(e,t,n){return t in e?re(e,t,{enumerable:!0,configurable:!0,writable:!0,value:n}):e[t]=n};var ce=m({themeMode:typeof matchMedia<"u"&&matchMedia("(prefers-color-scheme: dark)").matches?"dark":"light"}),ue={state:ce,subscribe:function(e){return y(ce,(function(){return e(ce)}))},setThemeConfig:function(e){var t=e.themeMode,n=e.themeVariables;t&&(ce.themeMode=t),n&&(ce.themeVariables=function(e,t){for(var n in t||(t={}))oe.call(t,n)&&se(e,n,t[n]);if(ae){var r,o=(0,a.Z)(ae(t));try{for(o.s();!(r=o.n()).done;)n=r.value,ie.call(t,n)&&se(e,n,t[n])}catch(i){o.e(i)}finally{o.f()}}return e}({},n))}},le=m({open:!1,message:"",variant:"success"}),de={state:le,subscribe:function(e){return y(le,(function(){return e(le)}))},openToast:function(e,t){le.open=!0,le.message=e,le.variant=t},closeToast:function(){le.open=!1}};typeof window<"u"&&(window.Buffer||(window.Buffer=I.Buffer),window.global||(window.global=window),window.process||(window.process={env:{}}))},72185:function(e,t,n){n.r(t),n.d(t,{Web3Modal:function(){return v}});var r=n(74165),a=n(15861),o=n(15671),i=n(43144),s=n(37762),c=n(76285),u=Object.defineProperty,l=Object.getOwnPropertySymbols,d=Object.prototype.hasOwnProperty,f=Object.prototype.propertyIsEnumerable,p=function(e,t,n){return t in e?u(e,t,{enumerable:!0,configurable:!0,writable:!0,value:n}):e[t]=n},v=function(){function e(t){(0,o.Z)(this,e),this.openModal=c.jb.open,this.closeModal=c.jb.close,this.subscribeModal=c.jb.subscribe,this.setTheme=c.Ic.setThemeConfig,c.Ic.setThemeConfig(t),c.t0.setConfig(function(e,t){for(var n in t||(t={}))d.call(t,n)&&p(e,n,t[n]);if(l){var r,a=(0,s.Z)(l(t));try{for(a.s();!(r=a.n()).done;)n=r.value,f.call(t,n)&&p(e,n,t[n])}catch(o){a.e(o)}finally{a.f()}}return e}({enableStandaloneMode:!0},t)),this.initUi()}return(0,i.Z)(e,[{key:"initUi",value:function(){var e=(0,a.Z)((0,r.Z)().mark((function e(){var t;return(0,r.Z)().wrap((function(e){for(;;)switch(e.prev=e.next){case 0:if(!(typeof window<"u")){e.next=5;break}return e.next=3,Promise.all([n.e(6316),n.e(6023),n.e(138)]).then(n.bind(n,30138));case 3:t=document.createElement("w3m-modal"),document.body.insertAdjacentElement("beforeend",t),c.zb.setIsUiLoaded(!0);case 5:case"end":return e.stop()}}),e)})));return function(){return e.apply(this,arguments)}}()}]),e}()}}]);